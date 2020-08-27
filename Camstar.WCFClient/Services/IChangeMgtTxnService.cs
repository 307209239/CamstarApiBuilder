// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeMgtTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeMgtTxnService
  {
    [OperationContract]
    ResultStatus BuildEmptySelectionValues(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_BuildEmptySelectionValues_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus DoesPermissionExistInRole(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_DoesPermissionExistInRole_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_LoadESigDetails_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus SelectionValues_Validation(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Parameters parameters,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeMgtTxnMethod[] methods,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeMgtTxn changeMgtTxn,
      ChangeMgtTxn_Request request,
      out ChangeMgtTxn_Result result);
  }
}
