// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessModelTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessModelTemplateMaintService
  {
    [OperationContract]
    ResultStatus AddBusinessRule(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_LoadESigDetails_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ValidateEmployeeRoleCombination(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessModelTemplateMaintMethod[] methods,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result);
  }
}
