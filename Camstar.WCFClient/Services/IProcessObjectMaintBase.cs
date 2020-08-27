// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessObjectMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IProcessObjectMaintBase : ISubentityMaintenanceBase
  {
    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(DCObject processObjectMaint);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate();

    [OperationContract]
    ResultStatus LoadBusinessRules(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      DCObject processObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(DCObject processObjectMaint);

    [OperationContract]
    ResultStatus LoadBusinessRules();

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(DCObject processObjectMaint);

    [OperationContract]
    ResultStatus LoadChecklistTemplate();

    [OperationContract]
    ResultStatus LoadTemplate(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      DCObject processObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadTemplate(DCObject processObjectMaint);

    [OperationContract]
    ResultStatus LoadTemplate();

    [OperationContract]
    ResultStatus PreviewChecklist(
      DCObject processObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      DCObject processObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(DCObject processObjectMaint);

    [OperationContract]
    ResultStatus PreviewChecklist();
  }
}
