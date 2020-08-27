// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGenericTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGenericTxnsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_LoadESigDetails_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_PopulateService_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService_Specific(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus PopulateService_User(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GenericTxnsMethod[] methods,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result);
  }
}
