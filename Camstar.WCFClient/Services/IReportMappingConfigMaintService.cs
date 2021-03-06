﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReportMappingConfigMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReportMappingConfigMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_LoadESigDetails_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Parameters parameters,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReportMappingConfigMaintMethod[] methods,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReportMappingConfigMaint reportMappingConfigMaint,
      ReportMappingConfigMaint_Request request,
      out ReportMappingConfigMaint_Result result);
  }
}
