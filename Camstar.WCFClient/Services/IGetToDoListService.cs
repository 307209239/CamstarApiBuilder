// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetToDoListService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetToDoListService
  {
    [OperationContract]
    ResultStatus GetToDoList(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Parameters parameters,
      GetToDoList_Request request,
      out GetToDoList_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Parameters parameters,
      GetToDoList_Request request,
      out GetToDoList_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetToDoListMethod[] methods,
      GetToDoList_Request request,
      out GetToDoList_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Request request,
      out GetToDoList_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Request request,
      out GetToDoList_Result result);
  }
}
