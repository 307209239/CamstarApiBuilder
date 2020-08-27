// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerStatusChangeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerStatusChangeService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_LoadESigDetails_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Parameters parameters,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerStatusChangeMethod[] methods,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerStatusChange containerStatusChange,
      ContainerStatusChange_Request request,
      out ContainerStatusChange_Result result);
  }
}
