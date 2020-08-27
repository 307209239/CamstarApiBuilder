// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IInspectionLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IInspectionLevelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_LoadESigDetails_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      InspectionLevelMaintMethod[] methods,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result);
  }
}
