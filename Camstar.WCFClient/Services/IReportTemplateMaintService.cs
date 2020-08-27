// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReportTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReportTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus DownloadFile(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_LoadESigDetails_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Parameters parameters,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReportTemplateMaintMethod[] methods,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReportTemplateMaint reportTemplateMaint,
      ReportTemplateMaint_Request request,
      out ReportTemplateMaint_Result result);
  }
}
