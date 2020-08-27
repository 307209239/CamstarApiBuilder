// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserCodeWithWMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserCodeWithWMMaintService : UserCodeMaintBase
  {
    public UserCodeWithWMMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserCodeWithWMMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).Delete(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Delete(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.Delete(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Delete(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.Delete(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).Freeze(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Freeze(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.Freeze(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Freeze(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.Freeze(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.GetWIPMsgs(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.GetWIPMsgs(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).Load(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Load(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.Load(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus Load(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.Load(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_LoadESigDetails_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).LoadESigDetails(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.LoadESigDetails, (UserCodeWithWMMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_LoadESigDetails_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.LoadESigDetails(userCodeWithWMMaint, (UserCodeWithWMMaint_LoadESigDetails_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.LoadESigDetails(userCodeWithWMMaint, (UserCodeWithWMMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).New(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus New(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.New(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus New(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.New(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).NewCopy(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus NewCopy(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.NewCopy(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.NewCopy(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).SaveAs(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus SaveAs(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.SaveAs(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.SaveAs(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).UnFreeze(this._UserProfile, userCodeWithWMMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(userCodeWithWMMaint, UserCodeWithWMMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userCodeWithWMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserCodeWithWMMaint) null, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus UnFreeze(UserCodeWithWMMaint userCodeWithWMMaint)
    {
      return this.UnFreeze(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.UnFreeze(userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_LoadESigDetails_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.New((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userCodeWithWMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeWithWMMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserCodeWithWMMaint) userCodeWithWMMaint, (UserCodeWithWMMaint_Parameters) parameters, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      try
      {
        UserCodeWithWMMaintMethod[] methods = new UserCodeWithWMMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserCodeWithWMMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeWithWMMaint cdo,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      try
      {
        return ((IUserCodeWithWMMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserCodeWithWMMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserCodeWithWMMaint) cdo, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.GetEnvironment((UserCodeWithWMMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeWithWMMaint cdo,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      result = (UserCodeWithWMMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeWithWMMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserCodeWithWMMaintMethod(cdo, UserCodeWithWMMaintMethods.ExecuteTransaction, (UserCodeWithWMMaint_Parameters) null));
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
        UserCodeWithWMMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserCodeWithWMMaint) cdo, (UserCodeWithWMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserCodeWithWMMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserCodeWithWMMaint_Request) null, out UserCodeWithWMMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result)
    {
      return this.ExecuteTransaction((UserCodeWithWMMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserCodeWithWMMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserCodeWithWMMaintMethod(cdo, UserCodeWithWMMaintMethods.AddDataTransaction, (UserCodeWithWMMaint_Parameters) null));
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
        return this.AddDataTransaction((UserCodeWithWMMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
