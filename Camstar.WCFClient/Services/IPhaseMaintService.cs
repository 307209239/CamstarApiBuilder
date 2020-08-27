// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPhaseMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPhaseMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_LoadESigDetails_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Parameters parameters,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PhaseMaintMethod[] methods,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PhaseMaint phaseMaint,
      PhaseMaint_Request request,
      out PhaseMaint_Result result);
  }
}
