// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICancelApprovalSheetService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICancelApprovalSheetService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CancelApprovalSheetMethod[] methods,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result);
  }
}
