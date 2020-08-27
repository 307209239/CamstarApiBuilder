// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerDefectReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerDefectReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_LoadESigDetails_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Parameters parameters,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerDefectReasonMaintMethod[] methods,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerDefectReasonMaint containerDefectReasonMaint,
      ContainerDefectReasonMaint_Request request,
      out ContainerDefectReasonMaint_Result result);
  }
}
