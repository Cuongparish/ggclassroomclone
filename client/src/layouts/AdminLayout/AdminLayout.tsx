import React from 'react';

interface LayoutProp {
  children: React.ReactNode | React.ReactElement<unknown>;
}

function AdminLayout({ children }: LayoutProp) {
  return (
    <div style={{ backgroundColor: '#FFFFFF' }}>
      {React.cloneElement(children as React.ReactElement<unknown>)}
    </div>
  );
}

export default AdminLayout;