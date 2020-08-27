// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMfgCalendarMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMfgCalendarMaintService
  {
    [OperationContract]
    ResultStatus CheckShiftAction(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_LoadESigDetails_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MfgCalendarMaintMethod[] methods,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result);
  }
}
