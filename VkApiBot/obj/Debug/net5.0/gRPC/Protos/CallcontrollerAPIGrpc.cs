// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC/Protos/callcontrollerAPI.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CallControllerService {
  public static partial class CallControllerAPI
  {
    static readonly string __ServiceName = "callcontrollerserviceAPI.CallControllerAPI";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::CallControllerService.CallReply> __Marshaller_callcontrollerserviceAPI_CallReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CallControllerService.CallReply.Parser));

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetNextCall = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNextCall",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerserviceAPI_CallReply);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetListCalls = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetListCalls",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerserviceAPI_CallReply);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetListNextCalls = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetListNextCalls",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerserviceAPI_CallReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CallControllerService.CallcontrollerAPIReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CallControllerAPI</summary>
    public partial class CallControllerAPIClient : grpc::ClientBase<CallControllerAPIClient>
    {
      /// <summary>Creates a new client for CallControllerAPI</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CallControllerAPIClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CallControllerAPI that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CallControllerAPIClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CallControllerAPIClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CallControllerAPIClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::CallControllerService.CallReply GetNextCall(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNextCall(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CallControllerService.CallReply GetNextCall(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNextCall, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CallControllerService.CallReply> GetNextCallAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNextCallAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CallControllerService.CallReply> GetNextCallAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNextCall, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::CallControllerService.CallReply> GetListCalls(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetListCalls(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::CallControllerService.CallReply> GetListCalls(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetListCalls, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::CallControllerService.CallReply> GetListNextCalls(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetListNextCalls(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::CallControllerService.CallReply> GetListNextCalls(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetListNextCalls, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CallControllerAPIClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CallControllerAPIClient(configuration);
      }
    }

  }
}
#endregion
