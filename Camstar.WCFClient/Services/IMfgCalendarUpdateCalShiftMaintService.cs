// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMfgCalendarUpdateCalShiftMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMfgCalendarUpdateCalShiftMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaintMethod[] methods,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result);
  }
}
