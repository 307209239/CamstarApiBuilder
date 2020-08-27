// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBusinessProcessTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBusinessProcessTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_LoadESigDetails_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BusinessProcessTxnMethod[] methods,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result);
  }
}
