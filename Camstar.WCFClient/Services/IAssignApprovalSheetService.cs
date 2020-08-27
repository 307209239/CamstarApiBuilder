// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignApprovalSheetService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignApprovalSheetService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus CreateSheet(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheet(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Parameters parameters,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignApprovalSheetMethod[] methods,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignApprovalSheet assignApprovalSheet,
      AssignApprovalSheet_Request request,
      out AssignApprovalSheet_Result result);
  }
}
