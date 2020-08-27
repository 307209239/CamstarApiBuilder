// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEMailNotificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEMailNotificationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_LoadESigDetails_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EMailNotificationMaintMethod[] methods,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result);
  }
}
