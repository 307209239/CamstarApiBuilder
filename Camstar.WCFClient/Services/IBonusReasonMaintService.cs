// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBonusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBonusReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_LoadESigDetails_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BonusReasonMaintMethod[] methods,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result);
  }
}
