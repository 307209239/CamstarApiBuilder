// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerAttrMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerAttrMaintService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus GetAttributes(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_LoadESigDetails_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Parameters parameters,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerAttrMaintMethod[] methods,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerAttrMaint containerAttrMaint,
      ContainerAttrMaint_Request request,
      out ContainerAttrMaint_Result result);
  }
}
