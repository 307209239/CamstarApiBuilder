// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveTxnsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_LoadESigDetails_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Parameters parameters,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveTxnsMethod[] methods,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveTxns moveTxns,
      MoveTxns_Request request,
      out MoveTxns_Result result);
  }
}
