// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRegulatoryReportTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRegulatoryReportTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_LoadESigDetails_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RegulatoryReportTypeMaintMethod[] methods,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result);
  }
}
