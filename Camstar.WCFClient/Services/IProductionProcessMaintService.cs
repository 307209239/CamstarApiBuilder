// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProductionProcessMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProductionProcessMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_LoadESigDetails_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProductionProcessMaintMethod[] methods,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result);
  }
}
