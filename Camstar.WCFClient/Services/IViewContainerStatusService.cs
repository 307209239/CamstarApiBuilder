// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IViewContainerStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IViewContainerStatusService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ViewContainerStatus viewContainerStatus,
      ViewContainerStatus_Parameters parameters,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ViewContainerStatusMethod[] methods,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ViewContainerStatus viewContainerStatus,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ViewContainerStatus viewContainerStatus,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result);
  }
}
