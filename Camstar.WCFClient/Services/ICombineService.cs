// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICombineService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICombineService
  {
    [OperationContract]
    ResultStatus Combine_ContainerExecute(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus Combine_QuantityExecute(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus GetCombineToContainers(
      UserProfile userProfile,
      Combine combine,
      Combine_GetCombineToContainers_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Combine combine,
      Combine_LoadESigDetails_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus ValidateContainerCombine(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus ValidateQtyCombine(
      UserProfile userProfile,
      Combine combine,
      Combine_Parameters parameters,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CombineMethod[] methods,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Combine combine,
      Combine_Request request,
      out Combine_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Combine combine,
      Combine_Request request,
      out Combine_Result result);
  }
}
