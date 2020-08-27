// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHoldReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHoldReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_LoadESigDetails_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HoldReasonMaintMethod[] methods,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result);
  }
}
