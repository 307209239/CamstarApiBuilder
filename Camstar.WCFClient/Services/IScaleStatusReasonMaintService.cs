// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScaleStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScaleStatusReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_LoadESigDetails_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Parameters parameters,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScaleStatusReasonMaintMethod[] methods,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScaleStatusReasonMaint scaleStatusReasonMaint,
      ScaleStatusReasonMaint_Request request,
      out ScaleStatusReasonMaint_Result result);
  }
}
