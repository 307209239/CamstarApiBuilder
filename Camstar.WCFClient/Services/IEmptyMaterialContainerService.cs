// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEmptyMaterialContainerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEmptyMaterialContainerService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus GetMaterialSelectionValues(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_GetMaterialSelectionValues_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_LoadESigDetails_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EmptyMaterialContainerMethod[] methods,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result);
  }
}
