﻿using System.Threading.Tasks;
using Amazon.S3;
using Storage.Net.Blob;

namespace Storage.Net.Amazon.Aws.Blob
{
   /// <summary>
   /// Provides access to native operations
   /// </summary>
   public interface IAwsS3BlobStorage : IBlobStorage
   {
      /// <summary>
      /// Returns reference to the native AWS S3 blob client.
      /// </summary>
      IAmazonS3 NativeBlobClient { get; }

      /// <summary>
      /// Get presigned url for upload object to Blob Storage.
      /// </summary>
      Task<string> GetUploadUrlAsync(string id, string mimeType, int expiresInSeconds = 86000);

      /// <summary>
      /// Get presigned url for download object from Blob Storage.
      /// </summary>
      Task<string> GetDownloadUrlAsync(string id, string mimeType, int expiresInSeconds = 86000);

      /// <summary>
      /// Get presigned url for requested operation with Blob Storage.
      /// </summary>
      Task<string> GetPresignedUrlAsync(string id, string mimeType, int expiresInSeconds, HttpVerb verb);
   }
}