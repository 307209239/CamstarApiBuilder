// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserQueryGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserQueryGroupMaintService : NamedObjectGroupMaintBase
  {
    public UserQueryGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserQueryGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).Delete(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Delete(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.Delete(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Delete(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.Delete(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).Freeze(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Freeze(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.Freeze(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.Freeze(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.GetWIPMsgs(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.GetWIPMsgs(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).Load(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Load(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.Load(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus Load(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.Load(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_LoadESigDetails_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.LoadESigDetails, (UserQueryGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserQueryGroupMaint) null, (UserQueryGroupMaint_LoadESigDetails_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.LoadESigDetails(userQueryGroupMaint, (UserQueryGroupMaint_LoadESigDetails_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.LoadESigDetails(userQueryGroupMaint, (UserQueryGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).New(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus New(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.New(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus New(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.New(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).NewCopy(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus NewCopy(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.NewCopy(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.NewCopy(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).SaveAs(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus SaveAs(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.SaveAs(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.SaveAs(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).UnFreeze(this._UserProfile, userQueryGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(userQueryGroupMaint, UserQueryGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userQueryGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserQueryGroupMaint) null, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(UserQueryGroupMaint userQueryGroupMaint)
    {
      return this.UnFreeze(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.UnFreeze(userQueryGroupMaint, (UserQueryGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_LoadESigDetails_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userQueryGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserQueryGroupMaint) userQueryGroupMaint, (UserQueryGroupMaint_Parameters) parameters, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      try
      {
        UserQueryGroupMaintMethod[] methods = new UserQueryGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserQueryGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserQueryGroupMaint cdo,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      try
      {
        return ((IUserQueryGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserQueryGroupMaint) cdo, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.GetEnvironment((UserQueryGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserQueryGroupMaint cdo,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      result = (UserQueryGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserQueryGroupMaintMethod(cdo, UserQueryGroupMaintMethods.ExecuteTransaction, (UserQueryGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserQueryGroupMaint) cdo, (UserQueryGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserQueryGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserQueryGroupMaint_Request) null, out UserQueryGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result)
    {
      return this.ExecuteTransaction((UserQueryGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserQueryGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserQueryGroupMaintMethod(cdo, UserQueryGroupMaintMethods.AddDataTransaction, (UserQueryGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((UserQueryGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
