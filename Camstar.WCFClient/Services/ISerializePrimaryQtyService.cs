// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISerializePrimaryQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISerializePrimaryQtyService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_LoadESigDetails_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SerializePrimaryQtyMethod[] methods,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result);
  }
}
