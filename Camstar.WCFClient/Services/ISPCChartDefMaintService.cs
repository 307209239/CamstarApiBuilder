// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISPCChartDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISPCChartDefMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_LoadESigDetails_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SPCChartDefMaintMethod[] methods,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result);
  }
}
