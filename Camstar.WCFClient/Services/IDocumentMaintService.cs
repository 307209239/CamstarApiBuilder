// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDocumentMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDocumentMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus DocumentMaint_Validations(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus DownloadFile(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_LoadESigDetails_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus UploadFile(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DocumentMaintMethod[] methods,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result);
  }
}
