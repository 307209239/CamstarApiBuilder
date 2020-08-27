// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChgContainerAttributeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChgContainerAttributeService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus GetAttributes(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_LoadESigDetails_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChgContainerAttributeMethod[] methods,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result);
  }
}
