// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISummaryTableDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISummaryTableDefMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_LoadESigDetails_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SummaryTableDefMaintMethod[] methods,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result);
  }
}
