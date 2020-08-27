// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeStatusTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeStatusTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_LoadESigDetails_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus ProcessModelingLocks(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Parameters parameters,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeStatusTxnMethod[] methods,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeStatusTxn changeStatusTxn,
      ChangeStatusTxn_Request request,
      out ChangeStatusTxn_Result result);
  }
}
