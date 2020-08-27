// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceActivationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceActivationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_LoadESigDetails_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Parameters parameters,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceActivationMethod[] methods,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceActivation resourceActivation,
      ResourceActivation_Request request,
      out ResourceActivation_Result result);
  }
}
