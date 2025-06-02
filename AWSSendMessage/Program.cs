// See https://aka.ms/new-console-template for more information
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

Console.WriteLine("Hello, World!");

RegionEndpoint ServiceRegion = RegionEndpoint.USEast1;
IAmazonSQS client = new AmazonSQSClient(ServiceRegion);

var url = "https://sqs.us-east-1.amazonaws.com/424557340333/aspnet-b11-queue";
var body = "Hello I am Atikul From Brain Station";

await SendMessage(client, url, body, null);

static async Task<SendMessageResponse> SendMessage(
          IAmazonSQS client,
          string queueUrl,
          string messageBody,
          Dictionary<string, MessageAttributeValue> messageAttributes)
{
    var sendMessageRequest = new SendMessageRequest
    {
        DelaySeconds = 10,
        MessageAttributes = messageAttributes,
        MessageBody = messageBody,
        QueueUrl = queueUrl,
    };

    var response = await client.SendMessageAsync(sendMessageRequest);
    Console.WriteLine($"Sent a message with id : {response.MessageId}");

    return response;
}