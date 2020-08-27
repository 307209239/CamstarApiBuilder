// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISPCChartDefGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISPCChartDefGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_LoadESigDetails_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Parameters parameters,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SPCChartDefGroupMaintMethod[] methods,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SPCChartDefGroupMaint sPCChartDefGroupMaint,
      SPCChartDefGroupMaint_Request request,
      out SPCChartDefGroupMaint_Result result);
  }
}
