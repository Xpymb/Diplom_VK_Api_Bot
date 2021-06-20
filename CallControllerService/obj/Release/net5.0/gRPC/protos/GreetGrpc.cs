// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC/protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CallControllerService {
  public static partial class CallControllerAPI
  {
    static readonly string __ServiceName = "callcontrollerAPI.CallControllerAPI";

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
    static readonly grpc::Marshaller<global::CallControllerService.CallReply> __Marshaller_callcontrollerAPI_CallReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CallControllerService.CallReply.Parser));

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetNextCall = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNextCall",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerAPI_CallReply);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetListCalls = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetListCalls",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerAPI_CallReply);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> __Method_GetListNextCalls = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetListNextCalls",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_callcontrollerAPI_CallReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CallControllerService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CallControllerAPI</summary>
    [grpc::BindServiceMethod(typeof(CallControllerAPI), "BindService")]
    public abstract partial class CallControllerAPIBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CallControllerService.CallReply> GetNextCall(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetListCalls(grpc::IAsyncStreamReader<global::Google.Protobuf.WellKnownTypes.Empty> requestStream, grpc::IServerStreamWriter<global::CallControllerService.CallReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetListNextCalls(grpc::IAsyncStreamReader<global::Google.Protobuf.WellKnownTypes.Empty> requestStream, grpc::IServerStreamWriter<global::CallControllerService.CallReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

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
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> GetListCalls(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetListCalls(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> GetListCalls(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetListCalls, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> GetListNextCalls(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetListNextCalls(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply> GetListNextCalls(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetListNextCalls, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CallControllerAPIClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CallControllerAPIClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CallControllerAPIBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetNextCall, serviceImpl.GetNextCall)
          .AddMethod(__Method_GetListCalls, serviceImpl.GetListCalls)
          .AddMethod(__Method_GetListNextCalls, serviceImpl.GetListNextCalls).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CallControllerAPIBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetNextCall, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(serviceImpl.GetNextCall));
      serviceBinder.AddMethod(__Method_GetListCalls, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(serviceImpl.GetListCalls));
      serviceBinder.AddMethod(__Method_GetListNextCalls, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CallControllerService.CallReply>(serviceImpl.GetListNextCalls));
    }

  }
}
#endregion
