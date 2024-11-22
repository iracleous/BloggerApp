import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import AppBlogger from './AppBlogger.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <AppBlogger />
  </StrictMode>,
)
