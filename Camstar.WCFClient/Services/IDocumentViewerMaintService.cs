// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDocumentViewerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDocumentViewerMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_LoadESigDetails_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DocumentViewerMaintMethod[] methods,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result);
  }
}
