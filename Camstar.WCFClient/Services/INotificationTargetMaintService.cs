// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INotificationTargetMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INotificationTargetMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_LoadESigDetails_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NotificationTargetMaintMethod[] methods,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result);
  }
}
