// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessObjectTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessObjectTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus SaveApprovalSheet(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus ValidateReassignmentAllowed(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_ValidateReassignmentAllowed_Parameters parameters,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessObjectTxnMethod[] methods,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessObjectTxn processObjectTxn,
      ProcessObjectTxn_Request request,
      out ProcessObjectTxn_Result result);
  }
}
