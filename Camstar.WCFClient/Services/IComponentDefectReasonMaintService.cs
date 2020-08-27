// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentDefectReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentDefectReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_LoadESigDetails_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentDefectReasonMaintMethod[] methods,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result);
  }
}
