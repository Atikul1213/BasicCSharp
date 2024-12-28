

CREATE OR ALTER PROCEDURE [dbo].[GetCourseEnrollment]		   -- Procedure Name
@PageIndex int,
@PageSize int,
@OrderBy nvarchar(50),
@CourseName nvarchar(250) = '%',
@StudentName nvarchar(250) = '%',
@FeeFrom decimal = null,					--Paramerter 
@FeeTo decimal = null, 
@Total int output,
@TotalDisplay int output

As 
BEGIN
	Declare @sql nvarchar(2000);
	Declare @countSql nvarchar(2000);
	Declare @paramList nvarchar(MAX);				-- Variable declare
	Declare @countparamList nvarchar(MAX);
	Declare @xTotalDisplay int;

	Select @Total = count(*)
				    from CourseStudents;

-- Here @xCourseName assing the Input value
    SET @countSql = 'select @xTotalDisplay = count(*)
					from CourseStudents cs inner join 
					Courses c on cs.CourseId = c.Id inner join 
					Students s on cs.StudentId = s.Id 
					where 1 = 1 ';

					IF @CourseName IS NOT NULL
					SET @countSql = @countSql +  ' AND c.Name LIKE ''%'' + @xCourseName + ''%''' 	

					IF @StudentName IS NOT NULL
					SET @countSql = @countSql + ' AND s.Name LIKE ''%'' + @xStudentName + ''%'''

					IF @FeeFrom IS NOT NULL
					SET @countSql = @countSql + ' AND Fee >= @xFeeFrom'

				    IF @FeeTo IS NOT NULL
					SET @countSql = @countSql + ' AND Fee <= @xFeeTo' 



    SET @sql = 'select c.Name as CourseName, s.Name as StudentName, c.Fee 
					from CourseStudents cs inner join
					Courses c on cs.CourseId = c.Id inner join
					Students s on cs.StudentId = s.Id 
					where 1 = 1 ';

					IF @CourseName IS NOT NULL
					SET @sql = @sql +  ' AND c.Name LIKE ''%'' + @xCourseName + ''%''' 

					IF @StudentName IS NOT NULL
					SET @sql = @sql + ' AND s.Name LIKE ''%'' + @xStudentName + ''%'''


					IF @FeeFrom IS NOT NULL
					SET @sql = @sql + ' AND Fee >= @xFeeFrom'

					IF @FeeTo IS NOT NULL
					SET @sql = @sql + ' AND Fee <= @xFeeTo'


					SET @sql = @sql + ' Order by ' + @OrderBy+' OFFSET @xPageSize * (@xPageIndex -1)
							   ROWS FETCH NEXT @xPageSize ROWS ONLY';

	--Parameter list Pass in the Dynamic Sql and Mention the placeholder name

	SELECT @countparamList = '@xCourseName nvarchar(250),
							 @xStudentName nvarchar(250),
							 @xFeeFrom decimal,							
							 @xFeeTo decimal,
							 @xTotalDisplay int output';


    --Parameter list Pass in the Dynamic Sql and Mention the placeholder name
	SELECT @paramList = '@xCourseName nvarchar(250),
					    @xStudentName nvarchar(250),
						@xFeeFrom decimal,
						@xFeeTo decimal,
						@xPageIndex int,
						@xPageSize int';

    -- Build in store procedure 
	-- pass sql, pass parameter list,  pass parameter
	exec sp_executesql @countsql , @countparamlist,
					   @CourseName,
					   @Studentname,
					   @FeeFrom,
					   @FeeTo,
					   @xTotalDisplay = @TotalDisplay output;


   
     -- Execute Count Query
    EXEC sp_executesql @countSql, 
        @countParamList,
        @CourseName,
        @StudentName,
        @FeeFrom,
        @FeeTo,
        @xTotalDisplay = @TotalDisplay OUTPUT;


    -- Build in store procedure 
	-- pass sql, pass parameter list,  pass parameter
     -- Execute Data Query
    EXEC sp_executesql @sql, 
					@paramList,
				    @CourseName,
					@StudentName,
					@FeeFrom,
					@FeeTo,
					@PageIndex,
					@PageSize;


	print @countsql;
	print @sql;
END

