// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ClassificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ClassificationMaintService : UserCodeMaintBase
  {
    public ClassificationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IClassificationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).Delete(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Delete(ClassificationMaint classificationMaint)
    {
      return this.Delete(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Delete(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.Delete(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).Freeze(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Freeze(ClassificationMaint classificationMaint)
    {
      return this.Freeze(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Freeze(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.Freeze(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ClassificationMaint classificationMaint)
    {
      return this.GetWIPMsgs(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.GetWIPMsgs(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).Load(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Load(ClassificationMaint classificationMaint)
    {
      return this.Load(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus Load(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.Load(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ClassificationMaint classificationMaint,
      ClassificationMaint_LoadESigDetails_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).LoadESigDetails(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.LoadESigDetails, (ClassificationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ClassificationMaint) null, (ClassificationMaint_LoadESigDetails_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ClassificationMaint classificationMaint)
    {
      return this.LoadESigDetails(classificationMaint, (ClassificationMaint_LoadESigDetails_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.LoadESigDetails(classificationMaint, (ClassificationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).New(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus New(ClassificationMaint classificationMaint)
    {
      return this.New(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus New(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.New(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).NewCopy(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus NewCopy(ClassificationMaint classificationMaint)
    {
      return this.NewCopy(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.NewCopy(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).SaveAs(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus SaveAs(ClassificationMaint classificationMaint)
    {
      return this.SaveAs(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.SaveAs(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) classificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).UnFreeze(this._UserProfile, classificationMaint, parameters, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(classificationMaint, ClassificationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) classificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ClassificationMaint) null, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus UnFreeze(ClassificationMaint classificationMaint)
    {
      return this.UnFreeze(classificationMaint, (ClassificationMaint_Parameters) null, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.UnFreeze(classificationMaint, (ClassificationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ClassificationMaint) classificationMaint, (ClassificationMaint_LoadESigDetails_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.New((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject classificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ClassificationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ClassificationMaint) classificationMaint, (ClassificationMaint_Parameters) parameters, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      try
      {
        ClassificationMaintMethod[] methods = new ClassificationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IClassificationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ClassificationMaint cdo,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      try
      {
        return ((IClassificationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ClassificationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ClassificationMaint) cdo, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.GetEnvironment((ClassificationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ClassificationMaint cdo,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      result = (ClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClassificationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ClassificationMaintMethod(cdo, ClassificationMaintMethods.ExecuteTransaction, (ClassificationMaint_Parameters) null));
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
        ClassificationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ClassificationMaint) cdo, (ClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ClassificationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ClassificationMaint_Request) null, out ClassificationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result)
    {
      return this.ExecuteTransaction((ClassificationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ClassificationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ClassificationMaintMethod(cdo, ClassificationMaintMethods.AddDataTransaction, (ClassificationMaint_Parameters) null));
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
        return this.AddDataTransaction((ClassificationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
