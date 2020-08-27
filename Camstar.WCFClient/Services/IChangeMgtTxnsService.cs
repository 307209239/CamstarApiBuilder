// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeMgtTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeMgtTxnsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_LoadESigDetails_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_PopulateService_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService_Specific(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService_User(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeMgtTxnsMethod[] methods,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result);
  }
}
