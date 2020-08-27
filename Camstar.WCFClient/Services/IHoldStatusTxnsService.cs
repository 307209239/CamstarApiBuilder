// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHoldStatusTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHoldStatusTxnsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_LoadESigDetails_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Parameters parameters,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HoldStatusTxnsMethod[] methods,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      HoldStatusTxns holdStatusTxns,
      HoldStatusTxns_Request request,
      out HoldStatusTxns_Result result);
  }
}
