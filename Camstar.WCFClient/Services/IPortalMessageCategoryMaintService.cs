// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPortalMessageCategoryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPortalMessageCategoryMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_LoadESigDetails_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PortalMessageCategoryMaintMethod[] methods,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result);
  }
}
