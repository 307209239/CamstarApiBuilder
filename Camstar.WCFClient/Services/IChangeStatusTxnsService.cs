// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeStatusTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeStatusTxnsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_LoadESigDetails_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Parameters parameters,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeStatusTxnsMethod[] methods,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeStatusTxns changeStatusTxns,
      ChangeStatusTxns_Request request,
      out ChangeStatusTxns_Result result);
  }
}
