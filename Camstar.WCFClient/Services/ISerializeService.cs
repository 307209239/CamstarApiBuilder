// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISerializeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISerializeService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_LoadESigDetails_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus ValidateContainerNames(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SerializeMethod[] methods,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result);
  }
}
