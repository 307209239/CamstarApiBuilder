// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerDefectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerDefectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus GetActuals(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_LoadESigDetails_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Parameters parameters,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerDefectMethod[] methods,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerDefect containerDefect,
      ContainerDefect_Request request,
      out ContainerDefect_Result result);
  }
}
