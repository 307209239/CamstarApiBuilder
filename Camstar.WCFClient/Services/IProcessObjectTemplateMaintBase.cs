// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessObjectTemplateMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IProcessObjectTemplateMaintBase : INamedDataObjectMaintBase
  {
    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(DCObject processObjectTemplateMaint);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate();

    [OperationContract]
    ResultStatus LoadBusinessRules(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(DCObject processObjectTemplateMaint);

    [OperationContract]
    ResultStatus LoadBusinessRules();

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(DCObject processObjectTemplateMaint);

    [OperationContract]
    ResultStatus LoadChecklistTemplate();

    [OperationContract]
    ResultStatus PreviewChecklist(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      DCObject processObjectTemplateMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(DCObject processObjectTemplateMaint);

    [OperationContract]
    ResultStatus PreviewChecklist();
  }
}
