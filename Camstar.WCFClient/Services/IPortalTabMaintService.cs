// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPortalTabMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPortalTabMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_LoadESigDetails_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Parameters parameters,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PortalTabMaintMethod[] methods,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PortalTabMaint portalTabMaint,
      PortalTabMaint_Request request,
      out PortalTabMaint_Result result);
  }
}
