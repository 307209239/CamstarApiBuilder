// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICloseCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICloseCPStatusService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_LoadESigDetails_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Parameters parameters,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CloseCPStatusMethod[] methods,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CloseCPStatus closeCPStatus,
      CloseCPStatus_Request request,
      out CloseCPStatus_Result result);
  }
}
