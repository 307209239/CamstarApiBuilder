// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScrapReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScrapReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_LoadESigDetails_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScrapReasonMaintMethod[] methods,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result);
  }
}
