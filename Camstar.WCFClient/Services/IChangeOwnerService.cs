// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeOwnerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeOwnerService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus SetTriageComplete(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Parameters parameters,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeOwnerMethod[] methods,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeOwner changeOwner,
      ChangeOwner_Request request,
      out ChangeOwner_Result result);
  }
}
