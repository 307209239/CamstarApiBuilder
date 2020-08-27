// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintClassActivationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintClassActivationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_LoadESigDetails_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Parameters parameters,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintClassActivationMethod[] methods,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaintClassActivation maintClassActivation,
      MaintClassActivation_Request request,
      out MaintClassActivation_Result result);
  }
}
