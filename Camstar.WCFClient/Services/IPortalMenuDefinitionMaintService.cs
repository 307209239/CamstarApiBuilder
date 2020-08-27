// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPortalMenuDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPortalMenuDefinitionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_LoadESigDetails_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PortalMenuDefinitionMaintMethod[] methods,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result);
  }
}
